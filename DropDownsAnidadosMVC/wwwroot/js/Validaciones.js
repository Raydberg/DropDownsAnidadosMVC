$(document).ready(function () {
    $("#sucursalDropdown").change(function () {
        var sucursalID = $(this).val();
        console.log("idSucursal: " + sucursalID);
        $("#categoriaDropdown").empty().append('<option value="">Seleccione una categoria</option>').prop("disabled", true);
        $("#productoDropdown").empty().append('<option value="">Seleccione un producto</option>').prop("disabled", true);
        if (sucursalID) {
            $.ajax({
                url: "/Home/ObtenerCategorias",
                type: "GET",
                data: { sucursalID: sucursalID },
                success: function (categorias) {
                    $.each(categorias, function (index, categoria) {
                        $("#categoriaDropdown").append('<option value="' + categoria.id + '">' + categoria.nombre + '</option>');
                    });
                    $("#categoriaDropdown").prop("disabled", false);
                }
            })
        }
    })

    // Evento change para el dropdown de categoría
    $("#categoriaDropdown").change(function () {
        var categoriaID = $(this).val();
        console.log("idCategoria: " + categoriaID);
        $("#productoDropdown").empty().append('<option value="">Seleccione un producto</option>').prop("disabled", true);
        if (categoriaID) {
            $.ajax({
                url: "/Home/ObtenerProductos",
                type: "GET",
                data: { categoriaID: categoriaID },
                success: function (productos) {
                    $.each(productos, function (index, producto) {
                        $("#productoDropdown").append('<option value="' + producto.id + '">' + producto.nombre + '</option>');
                    });
                    $("#productoDropdown").prop("disabled", false);
                }
            })
        }
    })
})