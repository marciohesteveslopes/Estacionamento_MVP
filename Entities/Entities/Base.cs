using Entities.Notifications;
using System.ComponentModel.DataAnnotations;

namespace Entities.Entities
{
    public  class Base : Notifies
    {
        [Display(Name = "Placa")]
        public string Id { get; set; }

    }
}
