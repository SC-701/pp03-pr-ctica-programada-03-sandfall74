using Abstracciones.Interfaces.Reglas;
using Abstracciones.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Web.Pages.Vehiculos
{
    public class AgregarModel : PageModel
    {
        private IConfiguracion _configuracion;
       
        public VehiculoRequest vehiculo { get; set; } = default!;
        
        public List<SelectListItem> marcas { get; set; } = default!;
        
        public List<SelectListItem> modelos { get; set; } = default!;
        public Guid marcaSeleccionada { get; set; } = default!;

        public AgregarModel(IConfiguracion configuracion)
        {
            _configuracion = configuracion;
        }

        public async Task OnGet()
        {

        }
    }
}
