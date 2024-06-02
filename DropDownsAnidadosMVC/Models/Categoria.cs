namespace DropDownsAnidadosMVC.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        //Foreign Key
        public int SucursalId { get; set; }

        //Propiedad de Navegacion

        public Sucursal Sucursal {  get; set; }

        //Relacionado uno a muchos 

        public ICollection<Producto> Productos { get; set; }
    }
}
