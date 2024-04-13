$(document).ready(function() {
    $(".block").hover(function() {
        $(this).toggleClass("active"); 
     });

    $(".nav_button").click(function() {
    $('header div a').slideToggle(300); 
    });

    $('#email').on('blur', function () {
        let email = $(this).val();
        
        if (email.length > 0
        && (email.match(/.+?\@.+/g) || []).length !== 1) {
          console.log('invalid');
          alert('Вы ввели некорректный e-mail!');
        }
    });

})

function save() {
    var name = document.getElementById("name").value;
    var email = document.getElementById("email").value;
    var datehappy = document.getElementById("datehappy").value;
    var user_value = document.getElementById("user_value").value;
    var user_value_rh = document.getElementById("user_value_rh").value;
    var user_value_status = document.getElementById("user_value_status").value;
    sessionStorage.setItem(name,email,datehappy,user_value,user_value_rh,user_value_status);
}

