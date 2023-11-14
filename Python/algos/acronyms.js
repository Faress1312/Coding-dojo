/* 
  Acronyms
  Create a function that, given a string, returns the string’s acronym 
  (first letter of each word capitalized). 
  Do it with .split first if you need to, then try to do it without
*/

const strA = "object oriented programming";
const expectedA = "OOP";

// The 4 pillars of OOP
const strB = "abstraction polymorphism inheritance encapsulation";
const expectedB = "APIE";

const strC = "software development life cycle";
const expectedC = "SDLC";

//- Bonus: ignore extra spaces
// const strD = "  global   information tracker    ";
// const expectedD = "GIT";
const str = 'object oriented programming';

function acronomize(str) {
    // Split the string into an array of words
    const words = str.split(" ");

    // Initialize an empty string to store the acronym
    let acronym = '';

    // Iterate over the words array and append the first character of each word to the acronym
    for (let i = 0; i < words.length; i++) {
        acronym += words[i].charAt(0).toUpperCase();
    }

    // Return the resulting acronym
    return acronym;
}

// Call the function with the provided string
const result = acronomize(str);

// Log the result to the console
console.log(result);

// 1 - split the text into single words
// 2 - create variable result 
// UpperCase() 
// 3 - add to result the first character of every word 
// var result = 0
// for result lenexpectedC
