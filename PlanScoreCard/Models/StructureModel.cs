using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PlanScoreCard.Models
{
    public class StructureModel : INotifyPropertyChanged
    {

        private string structureId;

        public string StructureId 
        {
            get { return structureId; }
            set
            {
                structureId = value;

                //if(String.IsNullOrWhiteSpace(structureId))
                //    TemplateStructureId = structureId;

                NotifyPropertyChanged();
            } 
        }

        private string structureComment;

        public string StructureComment
        {
            get { return structureComment; }
            set 
            { 
                structureComment = value;
                NotifyPropertyChanged();
            }
        }

        private string templateStructureId;

        public string TemplateStructureId
        {
            get { return templateStructureId; }
            set
            {
                templateStructureId = value;
                NotifyPropertyChanged();
            }
        }

        public string StructureCode { get; set; }
        public bool AutoGenerated { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        // This method is called by the Set accessor of each property.
        // The CallerMemberName attribute that is applied to the optional propertyName
        // parameter causes the property name of the caller to be substituted as an argument.
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }



    }
}
