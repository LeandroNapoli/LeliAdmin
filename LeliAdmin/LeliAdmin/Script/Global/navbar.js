$(document).ready(function () {
    selecionaMenu()
})


function selecionaMenu() {
    const menuSelecionado = $('#codigoMenu').val();
    if (menuSelecionado != "") {
        $('#' + menuSelecionado).addClass('active');
    }
}