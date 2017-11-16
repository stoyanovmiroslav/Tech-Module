function MultiplyNumbers(nums) {
    let number = 1;
    for(let i = 0; i < nums.length; i++){
        number = number * nums[i];
    }
    console.log(number);
}

MultiplyNumbers([2, 3])