// login logout button change

function changebutton(element) {
	if (element.innerText === "Login") {
		element.innerText = "logout";
	} else {
		element.innerText = "Login";
	}
}
function remove(element) {
	element.remove();
}
function alertMe() {
	
	alert(`Ninja was liked `);
	
}
