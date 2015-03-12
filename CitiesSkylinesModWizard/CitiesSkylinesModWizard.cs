using System;
using System.Collections.Generic;
using EnvDTE;
using Microsoft.VisualStudio.TemplateWizard; 

namespace CitiesSkylinesModWizard
{
    class CitiesSkylinesModWizard : IWizard
    {
        public void BeforeOpeningFile(ProjectItem projectItem) { }
        public void ProjectFinishedGenerating(Project project) { }
        public void ProjectItemFinishedGenerating(ProjectItem projectItem) { }
        public void RunFinished() { }

        public void RunStarted(object automationObject, Dictionary<string, string> replacementsDictionary, WizardRunKind runKind, object[] customParams)
        {
            BasicInfoForm bif = new BasicInfoForm();
            bif.ShowDialog();

            replacementsDictionary.Add("$name$", bif.Name);
            replacementsDictionary.Add("$description$", bif.Description);
            replacementsDictionary.Add("$path$", bif.Path);
        }

        public bool ShouldAddProjectItem(string filePath) { return true; } 
    }
}
