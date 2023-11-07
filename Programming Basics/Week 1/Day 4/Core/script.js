console.log("Hello from script.js 😁😁 **************");
function sayHello(){
    console.log("Hello FROM fUNCTION");
    // alert("Hello")
}

function show(element) {
    console.log("Element", element);
    console.log("Inner Text", element.innerText);
    console.log("Inner Html", element.innerHTML);
}

function changeMe(element) {
    if(element.innerText == "ON") {
        element.innerText  = "OFF"
        element.style.backgroundColor = "red"
    } else{
        element.innerText = "ON"
        element.style.backgroundColor = "greenyellow"
    }
}

function hide(button) {
    button.remove()
}
function subscribe(i) {
    if(i.innerText == "Subscribe") {
        alert("Thank you 😁")
        i.innerText = "Unsubscribe"
        i.style.backgroundColor ="coral"
    } else {
        alert("Sorry to see you leave 😢")
        i.innerText = "Subscribe"
        i.style.backgroundColor ="greenyellow"
    }
}
function over(element) {
    element.style.backgroundColor = "coral"
}
function out(element) {
    element.style.backgroundColor ="darkkhaki"
    
}