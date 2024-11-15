const switchers = [...document.querySelectorAll('.switcher')];

switchers.forEach(item => {
    item.addEventListener('click', function () {
        switchers.forEach(item => item.parentElement.classList.remove('is-active'));
        this.parentElement.classList.add('is-active');
    });
});

function toggleForm(formType) {
    if (formType === 'login') {
        document.querySelector('.form-login').style.display = 'block';
        document.querySelector('.form-signup').style.display = 'none';
        document.querySelector('.switcher-login').parentElement.classList.add('is-active');
        document.querySelector('.switcher-signup').parentElement.classList.remove('is-active');
    } else {
        document.querySelector('.form-signup').style.display = 'block';
        document.querySelector('.form-login').style.display = 'none';
        document.querySelector('.switcher-signup').parentElement.classList.add('is-active');
        document.querySelector('.switcher-login').parentElement.classList.remove('is-active');
    }
    disableValidationForHiddenFields();
}

function disableValidationForHiddenFields() {
    const forms = document.querySelectorAll('.form');
    forms.forEach(form => {
        const inputs = form.querySelectorAll('input');
        inputs.forEach(input => {
            if (form.style.display === 'none') {
                input.removeAttribute('required');
            } else {
                input.setAttribute('required', 'true');
            }
        });
    });
}

// Inicializar con el formulario de Login visible al cargar la página
toggleForm('login');
