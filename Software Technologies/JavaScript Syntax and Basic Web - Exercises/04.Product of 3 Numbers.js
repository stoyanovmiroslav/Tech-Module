function NegativeOrPositive(nums) {
    let countNegative = 0;
    for(let i = 0; i < nums.length; i++){
      if(nums[i] < 0){
       countNegative++;
      }
    }
    if(countNegative % 2 == 0){
        console.log("Positive");
    }else {
        console.log("Negative");
    }
}

NegativeOrPositive([2, 3, -1])

