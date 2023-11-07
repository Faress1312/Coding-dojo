var arr2d = [
    [2,5,8]
    [3,6,1]
    [5,7,7]
]
function arrflatten(arr2d){
    var newArr = [];
        for(var i =0 ; i<arr2d.length ; i++){
            for( var j =0 ; i<arr2d.length ; i++){
                newArr.push(arr2d[i][j]);
            }
        }
        return newArr
}