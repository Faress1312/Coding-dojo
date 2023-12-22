const cars = ['Tesla', 'Mercedes', 'Honda']
const randomCar  = cars[2]
const otherRandomCar = cars[0]

// i will take the first the third element
//Predict the o utput
// console.log(randomCar)
// console.log(otherRandomCar)
// console.log(randomCar,otherRandomCar);




const employee = {
    name: 'Elon',
    age: 47,
    company: 'Tesla'
}
//Predict the output


const otherName = employee.name
const {name, } = employee;
const {name:aka,} = employee;
// console.log("Destructuring : ",otherName );
// console.log("Destructuring with alias : ",aka, );

const person = {
    name: 'Phil Smith',
    age: 47,
    height: '6 feet'
}
const password = '12345';
const hashedPassword = '§?/.?./EDcdubcidfvcdfvdsdcV/CSDC§SD';

// console.log(password);
// console.log(hashedPassword);

const numbers = [8, 2, 3, 5, 6, 1, 67, 12, 2];
const [,first] = numbers;
const [,,,second] = numbers;
const [,,,,,,,,third] = numbers;

console.log(first == second);
console.log(first == third);

