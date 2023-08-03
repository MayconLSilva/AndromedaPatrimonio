(function() {
    var senha = document.getElementById('Senha');
    senha.addEventListener('blur', function()
   {
        senha.setAttribute("type", "password");
    });
    senha.addEventListener('focus', function()
   {
        senha.setAttribute("type", "text");
    });
})();