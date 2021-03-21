class CalculateApp1
{
    userInput1: HTMLInputElement;
    userInput2: HTMLInputElement;
    userInput3: HTMLInputElement;
    userInput4: HTMLInputElement;

    sumOutput: HTMLInputElement;
    averageOutput: HTMLInputElement;
    minimumOutput: HTMLInputElement;
    maximumOutput: HTMLInputElement;

    constructor()
    {
        this.openApplication();
    }

    openApplication()
    {
        this.getInputs();
        this.watchInputValues();
    }

    getInputs()
    {
        this.userInput1 = document.querySelector('#input1');
        this.userInput2 = document.querySelector('#input2');
        this.userInput3 = document.querySelector('#input3');
        this.userInput4 = document.querySelector('#input4');
        this.sumOutput = document.querySelector('#sum');
        this.averageOutput = document.querySelector('#average');
        this.minimumOutput = document.querySelector('#minimum');
        this.maximumOutput = document.querySelector('#maximum');
    }

    watchInputValues()
    {
        this.userInput1.addEventListener('input', () => this.computeData());
        this.userInput2.addEventListener('input', () => this.computeData());
        this.userInput3.addEventListener('input', () => this.computeData());
        this.userInput4.addEventListener('input', () => this.computeData());
    }   

    computeData()
    {
        const value1 = +this.userInput1.value;
        const value2 = +this.userInput2.value;
        const value3 = +this.userInput3.value;
        const value4 = +this.userInput4.value;  

        const sum = value1 + value2 + value3 + value4;
        const average = sum / 4;
        const minimum = Math.min(value1, value2, value3, value4);
        const maximum = Math.max(value1, value2, value3, value4);

        this.showValues(sum, average, minimum, maximum);
    }

    showValues(sum: number, average: number, minimum: number, maximum: number)
    {
        this.sumOutput.value = sum.toString();
        this.averageOutput.value = average.toString();
        this.minimumOutput.value = minimum.toString();
        this.maximumOutput.value = maximum.toString();

         
    }
}
const calculateApp1 = new CalculateApp1();