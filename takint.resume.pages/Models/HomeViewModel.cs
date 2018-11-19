using ff.words.application.ViewModels;
using System.Collections.Generic;

namespace takint.resume.pages.Models
{
    public class HomeViewModel : SharedViewModel
    {
        public IEnumerable<EntryViewModel> ListEntries { get; set; }
    }
}
