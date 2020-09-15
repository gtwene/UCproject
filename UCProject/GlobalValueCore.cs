using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Wisej.Web;

namespace UCProject
{
    public class GlobalValueCore
    {
        public static string ApplicationName { get; set; } = "CMS v3.0";

        public static bool CHECK_UI_IS_EMPTY(string ControlText, string ErrorMessage)
        {
            if (ControlText == string.Empty)
            {
                WarningMessage(ErrorMessage);
                return true;
            }
            return false;
        }


        public static bool CHECK_UI_IS_EMPTY(ComboBox cmb, string ControlText, string ErrorMessage)
        {
            try
            {
                if (cmb.SelectedIndex <= -1)
                {
                    WarningMessage(ErrorMessage);
                    return true;
                }
                if (ControlText == string.Empty)
                {
                    WarningMessage(ErrorMessage);
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                return true;
            }

        }

        public static bool CHECK_UI_IS_NUMERIC(string ControlText, string ErrorMessage)
        {
            if (!Information.IsNumeric(ControlText))
            {
                WarningMessage(ErrorMessage);
                return true;
            }
            else if (Convert.ToDecimal(ControlText) <= 0)
            {
                WarningMessage(ErrorMessage);
                return true;
            }
            return false;
        }

        public static bool CHECK_UI_IS_NUMERIC_ALLOW_ZERO(string ControlText, string ErrorMessage)
        {
            if (!Information.IsNumeric(ControlText))
            {
                WarningMessage(ErrorMessage);
                return true;
            }
            if (Convert.ToDecimal(ControlText) < 0)
            {
                WarningMessage(ErrorMessage);
                return true;
            }
            return false;
        }


        public static void ExceptionMessage(string exMessage)
        {
            MessageBox.Show("Error : " + exMessage, "CMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void InformationMessage(string exMessage)
        {
            MessageBox.Show(exMessage, "CMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void WarningMessage(string exMessage)
        {
            MessageBox.Show(exMessage, "CMS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


    }
}