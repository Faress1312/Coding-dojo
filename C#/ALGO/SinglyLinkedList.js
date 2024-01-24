//! SLL.JS

class SLL {
  constructor() {
    this.head = null;
  }
  isEmpty() {
    if (this.head) {
      return false;
    } else {
    }
  }
  isEmptyV01() {
    return this.head == null;
  }
  addToFront(data) {
    constnewNode = new Node(data);
    if (this.isEmpty()) {
      this.head = newNode;
      return this;
    } else {
      newNode.next = this.head;
      this.head = newNode;
      return this;
    }
  }
  addToFrontV01() {
    if (this.isEmpty()) {
      this.head = node;
      return this;
    } else {
      node.next = this.head;
      this.head = node;
      return this;
    }
  }
}
class Node {
  constructor(data) {
    this.data = data;
    this.next = null;
  }
}

const sll = new SLL();
const nodeOne = new Node(24);
const nodeTwo = new Node(2);
const nodeThree = new Node(-30);
const nodeFour = new Node(73);
sll.head = nodeOne;
console.log("Is SLL Empty? ->", sll.isEmpty());
console.log("Is SLL EmptyV01? ->", sll.isEmptyV01());
nodeOne.next = nodeTwo;
nodeTwo.next = nodeThree;
nodeThree.next = nodeFour;

// console.log(sll);

// console.log(nodeOne);
// console.log(nodeTwo);
console.log(nodeThree.next);
// console.log(nodeFour);
