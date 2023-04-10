let ano = document.querySelector(".ano");
let getData = new Date();

ano.innerHTML = getData.getFullYear();

const buttons = document.querySelectorAll('.nav-item-link');




// adicionando cor fixa apos o click //
// Adicione um evento de clique a cada botão
buttons.forEach(button => {
    debugger
  button.addEventListener('click', () => {
    // Remova a classe "selected" de todos os botões
    buttons.forEach(btn => {
      btn.classList.remove('selected');
    });

    // Adicione a classe "selected" ao botão clicado
    button.classList.add('selected');
  });
});
