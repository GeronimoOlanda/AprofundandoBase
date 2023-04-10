const nav_item = document.querySelectorAll('.nav-item-link');

// adicionando cor fixa apos o click //
// Adicione um evento de clique a cada botão
nav_item.forEach(item => {
  item.addEventListener('click', () => {
    // Remova a classe "selected" de todos os botões
    nav_item.forEach(btn => {
      btn.classList.remove('selected');
    });

    // Adicione a classe "selected" ao botão clicado
    item.classList.add('selected');
  });
});