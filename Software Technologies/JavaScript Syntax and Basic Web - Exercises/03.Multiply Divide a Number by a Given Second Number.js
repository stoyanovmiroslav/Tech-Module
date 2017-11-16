function MultiplyDivideNumbers(nums) {
    let number = 1;
    if(nums[0] > nums[1]){
        number = nums[0] / nums[1];
    }else{
        number = nums[0] * nums[1];
    }

    console.log(number);
}

MultiplyDivideNumbers([12, 3])
