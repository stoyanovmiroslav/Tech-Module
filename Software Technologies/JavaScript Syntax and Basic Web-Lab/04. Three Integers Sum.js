function SumNumbers([input]) {

    let splitInput = input.split(' ');
    let numbers = splitInput.map(Number).sort((a,b) => a - b);

    if (numbers[0] + numbers[1] == numbers[2]) {
        console.log(`${numbers[0]} + ${numbers[1]} = ${numbers[2]}`);
    }
    else if(numbers[2] + numbers[0] == numbers[1]) {
        console.log(`${numbers[0]} + ${numbers[2]} = ${numbers[1]}`);
    }
    else if(numbers[2] + numbers[1] == numbers[0]) {
        console.log(`${numbers[1]} + ${numbers[2]} = ${numbers[0]}`);
    }
    else{
        console.log("No");
    }
}

SumNumbers(["1 -10 11"]);