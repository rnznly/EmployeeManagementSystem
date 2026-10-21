using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EmployeeManagementSystem.Utilities
{
    /// <summary>
    /// Form input validation helpers using ErrorProvider.
    /// </summary>
    public static class ValidationHelper
    {
        private static readonly Regex EmailRegex = new Regex(
            @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
            RegexOptions.Compiled | RegexOptions.IgnoreCase);

        /// <summary>
        /// Validates that a string is non-empty and non-whitespace.
        /// </summary>
        public static bool ValidateRequired(Control control, ErrorProvider errorProvider, string fieldName)
        {
            if (control == null || errorProvider == null) return false;

            if (string.IsNullOrWhiteSpace(control.Text))
            {
                errorProvider.SetError(control, $"{fieldName} is required.");
                return false;
            }

            errorProvider.SetError(control, string.Empty);
            return true;
        }

        /// <summary>
        /// Validates an email address format.
        /// </summary>
        public static bool ValidateEmail(Control control, ErrorProvider errorProvider)
        {
            if (control == null || errorProvider == null) return false;

            string email = control.Text?.Trim() ?? string.Empty;
            if (string.IsNullOrEmpty(email))
            {
                errorProvider.SetError(control, "Email is required.");
                return false;
            }

            if (!EmailRegex.IsMatch(email))
            {
                errorProvider.SetError(control, "Please enter a valid email address (e.g. user@example.com).");
                return false;
            }

            errorProvider.SetError(control, string.Empty);
            return true;
        }

        /// <summary>
        /// Validates that hire date is greater than or equal to birth date.
        /// </summary>
        public static bool ValidateHireDate(DateTimePicker dtpHire, DateTimePicker dtpBirth, ErrorProvider errorProvider)
        {
            if (dtpHire == null || dtpBirth == null || errorProvider == null) return false;

            if (dtpHire.Value.Date < dtpBirth.Value.Date)
            {
                errorProvider.SetError(dtpHire, "Hire date cannot be earlier than birth date.");
                return false;
            }

            // Also check reasonable working age (e.g. at least 15 years old)
            int ageAtHire = dtpHire.Value.Year - dtpBirth.Value.Year;
            if (dtpHire.Value.Date < dtpBirth.Value.Date.AddYears(ageAtHire)) ageAtHire--;
            if (ageAtHire < 15)
            {
                errorProvider.SetError(dtpHire, $"Employee would only be {ageAtHire} years old at hire date. Please verify dates.");
                // warning but still allow if intended
            }
            else
            {
                errorProvider.SetError(dtpHire, string.Empty);
            }

            return true;
        }

        /// <summary>
        /// Validates that employment history end date is null/blank or >= start date.
        /// </summary>
        public static bool ValidateHistoryDates(DateTimePicker dtpStart, DateTimePicker dtpEnd, bool isCurrent, ErrorProvider errorProvider)
        {
            if (dtpStart == null || dtpEnd == null || errorProvider == null) return false;

            if (isCurrent)
            {
                errorProvider.SetError(dtpEnd, string.Empty);
                return true;
            }

            if (dtpEnd.Value.Date < dtpStart.Value.Date)
            {
                errorProvider.SetError(dtpEnd, "End date cannot be earlier than start date.");
                return false;
            }

            errorProvider.SetError(dtpEnd, string.Empty);
            return true;
        }

        /// <summary>
        /// Computes age in whole years given a birth date.
        /// </summary>
        public static int CalculateAge(DateTime birthDate, DateTime? asOf = null)
        {
            DateTime target = asOf ?? DateTime.Today;
            int age = target.Year - birthDate.Year;
            if (target < birthDate.AddYears(age))
            {
                age--;
            }
            return Math.Max(0, age);
        }
    }
}
