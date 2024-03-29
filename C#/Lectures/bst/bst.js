// Binary Search Tree

class Node {
  constructor(data) {
    this.data = data;
    this.left = null;
    this.right = null;
  }
}
class BST {
  constructor() {
    this.root = null;
  }
  isEmpty() {
    return this.root == null;
  }
  min() {
    if (this.isEmpty) {
      return false;
    } else {
      let runner = this.root;
      let minValue = runner.data;
      while (runner.left) {
        runner = runner.left;
        minValue = runner.left.data;
      }
    }
    console.log(minValue);

    return minValue;
  }
  max() {
    if (this.isEmpty) {
      return false;
    } else {
      let runner = this.root;
      let minValue = runner.data;
      while (runner.right) {
        runner = runner.right;
        minValue = runner.right.data;
      }
    }
    console.log(maxValue);
    return minValue;
  }
}

const nodeOne = new Node(26);
const nodeTwo = new Node(12);
const nodeThree = new Node(62);
const node4 = new Node(19);
const node5 = new Node(19);
const node6 = new Node(17);
const node7 = new Node(38);
const node8 = new Node(45);
const node9 = new Node(73);
const node10 = new Node(83);

nodeOne.left = nodeTwo;
nodeOne.right = nodeThree;
nodeTwo.left = node4;
nodeTwo.right = node5;
node5.left = node6;
nodeThree.left = node7;
node7.right = node8;
nodeThree.right = node9;
node9.right = node10;

const bst = new BST();
bst.root = nodeOne;
console.log("bst min =", bst.min());

