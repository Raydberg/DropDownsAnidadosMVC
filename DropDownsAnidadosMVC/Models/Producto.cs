namespace DropDownsAnidadosMVC.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double  Precio { get; set; }
        //Foreign Key
        public int CategoriaId { get; set; }

        //Propiedad de Navegacion
        public Categoria Categoria { get; set; }
    }
}
