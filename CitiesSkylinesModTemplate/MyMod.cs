namespace $safeprojectname$
{
    using System;
    using System.Collections.Generic;
    $if$ ($targetframeworkversion$ >= 3.5)using System.Linq;
    $endif$using System.Text;
    using ColossalFramework.UI;
    using ICities;
    using UnityEngine;

    public class MyMod : IUserMod
    { 

        public string Name
        {
            get
            {
                return "$name$";
            }
        } 

        public string Description
        {
            get
            {
                return "$description$";
            }
        } 
    } 
}
