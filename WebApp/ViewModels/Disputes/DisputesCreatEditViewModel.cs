using Domain.App;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApp.ViewModels.Disputes
{
    public class DisputesCreatEditViewModel
    {
        public Dispute Dispute { get; set; } = default!;
        public SelectList? DisputeStatusSelectList { get; set; }
        public SelectList? ErApplicationSelectList { get; set; }
    }
}