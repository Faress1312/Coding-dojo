function remove(element) {
	element.remove();
}
function like() {
    var e=document.querySelector('#likePlus')
    e.innerHTML++;
}
function likeme() {
    var e=document.querySelector('#likeme')
    e.innerHTML++;
}
function likeit() {
    var e=document.querySelector('#likeit')
    e.innerHTML++;
}
function alertMe() {
	var a=document.querySelector('#searchIn')

	alert("You are searching for " + a.value );
	
}