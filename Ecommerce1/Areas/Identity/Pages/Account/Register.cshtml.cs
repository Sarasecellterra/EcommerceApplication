// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Encodings.Web;
using Ecommerce1.Models; // Include your Models namespace
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;

namespace Ecommerce1.Areas.Identity.Pages.Account
{
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<AppUser> _signInManager; // SignIn manager for handling sign-in logic
        private readonly UserManager<AppUser> _userManager; // User manager for managing user accounts
        private readonly IUserStore<AppUser> _userStore; // Store for managing AppUser instances
        private readonly IUserEmailStore<AppUser> _emailStore; // Email store for managing user emails
        private readonly ILogger<RegisterModel> _logger; // Logger for logging events
        private readonly IEmailSender _emailSender; // Service for sending emails

        public RegisterModel(
            UserManager<AppUser> userManager,
            IUserStore<AppUser> userStore,
            SignInManager<AppUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender)
        {
            _userManager = userManager; // Dependency injection of UserManager
            _userStore = userStore; // Dependency injection of UserStore
            _emailStore = GetEmailStore(); // Get the email store
            _signInManager = signInManager; // Dependency injection of SignInManager
            _logger = logger; // Dependency injection of Logger
            _emailSender = emailSender; // Dependency injection of EmailSender
        }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        [BindProperty]
        public InputModel Input { get; set; } // Binding model for registration

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public string ReturnUrl { get; set; } // URL to redirect to after registration

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public IList<AuthenticationScheme> ExternalLogins { get; set; } // List of external authentication schemes available

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public class InputModel
        {
            /// <summary>
            ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
            ///     directly from your code. This API may change or be removed in future releases.
            /// </summary>
            [Required]
            [DataType(DataType.Text)]
            [Display(Name = "First Name")]
            public string FirstName { get; set; } // First name of the user

            [Required]
            [DataType(DataType.Text)]
            [Display(Name = "Last Name")]
            public string LastName { get; set; } // Last name of the user

            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; } // Email of the user

            /// <summary>
            ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
            ///     directly from your code. This API may change or be removed in future releases.
            /// </summary>
            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; } // Password for the user account

            /// <summary>
            ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
            ///     directly from your code. This API may change or be removed in future releases.
            /// </summary>
            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; } // Password confirmation
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl; // Set the return URL for redirection
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList(); // Load external logins
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/"); // Default return URL
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList(); // Load external logins
            if (ModelState.IsValid)
            {
                // Create a new AppUser instance with the provided information
                AppUser user = new AppUser
                {
                    FirstName = Input.FirstName, // Synchronize first name
                    LastName = Input.LastName, // Synchronize last name
                    UserName = Input.Email, // Use email as username
                    Email = Input.Email, // Set email
                };

                // Set the username and email for the user
                await _userStore.SetUserNameAsync(user, Input.Email, CancellationToken.None);
                await _emailStore.SetEmailAsync(user, Input.Email, CancellationToken.None);

                // Create the user with the hashed password using UserManager
                var result = await _userManager.CreateAsync(user, Input.Password);

                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");

                    var userId = await _userManager.GetUserIdAsync(user); // Get user ID
                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user); // Generate email confirmation token
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code)); // Encode the token
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { area = "Identity", userId = userId, code = code, returnUrl = returnUrl },
                        protocol: Request.Scheme); // Create confirmation URL

                    // Send email confirmation
                    await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    // Check if email confirmation is required
                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        return RedirectToPage("RegisterConfirmation", new { email = Input.Email, returnUrl = returnUrl });
                    }
                    else
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false); // Sign in the user
                        return LocalRedirect(returnUrl); // Redirect to return URL
                    }
                }

                // If registration fails, add errors to the model state
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description); // Add error messages
                }
            }

            // If we got this far, something failed, redisplay form
            return Page(); // Return the registration page with validation errors
        }

        private AppUser CreateUser()
        {
            try
            {
                return Activator.CreateInstance<AppUser>(); // Create a new instance of AppUser
            }
            catch
            {
                throw new InvalidOperationException($"Can't create an instance of '{nameof(AppUser)}'. " +
                    $"Ensure that '{nameof(AppUser)}' is not an abstract class and has a parameterless constructor, or alternatively " +
                    $"override the register page in /Areas/Identity/Pages/Account/Register.cshtml");
            }
        }

        private IUserEmailStore<AppUser> GetEmailStore()
        {
            if (!_userManager.SupportsUserEmail)
            {
                throw new NotSupportedException("The default UI requires a user store with email support.");
            }
            return (IUserEmailStore<AppUser>)_userStore; // Get the email store for the AppUser
        }
    }
}
