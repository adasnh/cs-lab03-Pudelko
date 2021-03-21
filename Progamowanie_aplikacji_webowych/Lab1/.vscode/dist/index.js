var CalculateApp1 = /** @class */ (function () {
    function CalculateApp1() {
        this.openApplication();
    }
    CalculateApp1.prototype.openApplication = function () {
        this.getInputs();
        this.watchInputValues();
    };
    CalculateApp1.prototype.getInputs = function () {
        this.userInput1 = document.querySelector('#input1');
        this.userInput2 = document.querySelector('#input2');
        this.userInput3 = document.querySelector('#input3');
        this.userInput4 = document.querySelector('#input4');
        this.sumOutput = document.querySelector('#sum');
        this.averageOutput = document.querySelector('#average');
        this.minimumOutput = document.querySelector('#minimum');
        this.maximumOutput = document.querySelector('#maximum');
    };
    CalculateApp1.prototype.watchInputValues = function () {
        var _this = this;
        this.userInput1.addEventListener('input', function () { return _this.computeData(); });
        this.userInput2.addEventListener('input', function () { return _this.computeData(); });
        this.userInput3.addEventListener('input', function () { return _this.computeData(); });
        this.userInput4.addEventListener('input', function () { return _this.computeData(); });
    };
    CalculateApp1.prototype.computeData = function () {
        var value1 = +this.userInput1.value;
        var value2 = +this.userInput2.value;
        var value3 = +this.userInput3.value;
        var value4 = +this.userInput4.value;
        var sum = value1 + value2 + value3 + value4;
        var average = sum / 4;
        var minimum = Math.min(value1, value2, value3, value4);
        var maximum = Math.max(value1, value2, value3, value4);
        this.showValues(sum, average, minimum, maximum);
    };
    CalculateApp1.prototype.showValues = function (sum, average, minimum, maximum) {
        this.sumOutput.value = sum.toString();
        this.averageOutput.value = average.toString();
        this.minimumOutput.value = minimum.toString();
        this.maximumOutput.value = maximum.toString();
    };
    return CalculateApp1;
}());
var calculateApp1 = new CalculateApp1();
