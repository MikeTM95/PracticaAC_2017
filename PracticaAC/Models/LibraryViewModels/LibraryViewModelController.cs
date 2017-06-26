using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PracticaAC.Models.LibraryViewModels
{
    public class LibraryViewModelController : Controller
    {
       public IList<BookViewModel> Books { get; set; }
    }
}