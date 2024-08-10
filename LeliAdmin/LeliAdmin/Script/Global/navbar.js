$(document).ready(function () {
    selecionaMenu()
})


function selecionaMenu() {
    const menuSelecionado = $('#codigoMenu').val();
    console.log = "Alo"
    if (menuSelecionado != "") {
        $('#' + menuSelecionado).addClass('active');
    }
}