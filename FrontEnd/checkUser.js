var userSession = JSON.parse(sessionStorage.getItem("user"));
if(!userSession){
    window.location.href = "login.html";
}

function logOut() {
    sessionStorage.removeItem("user");
    window.location.href = "login.html";
}



// var action_limitation = 8;
// if(+userSession.number_of_action > action_limitation){
//     alert("Go Out!")
//     window.location.href = "login.html";
// }
