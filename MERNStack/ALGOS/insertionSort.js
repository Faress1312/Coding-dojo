const insertionSort = (arr) => {
    console.log( `INPUT ARRAY : ${arr}`);
    for (let i = 1 ; i <arr.length; i++){
    let temp = arr[i]
    for (let j = i-1 ; j >= 0 ; j --) {
        if(temp < arr[j] ){
            arr[j+1]= arr[j]
            if (j===0){
                arr[j] = temp
            }
        }else{
            break
        }
    }
    }
}
console.log(`sorted array  : ${arr}`);

insertionSort([3,5,2,1,0])
insertionSort([3,0])
insertionSort([0])
insertionSort([1,2,3,4,5])
insertionSort([5,4,3,2,1])
