import { Day } from "../day";

class Day1 extends Day {

    constructor(){
        super(1);
    }

    solveForPartOne(input: string): string {
        let max = input.split(/\r?\n\r?\n/).map(deer => {
            return deer.split(/\r?\n/).map(food => parseInt(food)).reduce((prev, curr) => prev + curr)
        }).sort((a, b) => a-b).pop()

        return max?.toString() ?? "";
    }

    solveForPartTwo(input: string): string {
        let max = input.split(/\r?\n\r?\n/).map(deer => {
            return deer.split(/\r?\n/).map(food => parseInt(food)).reduce((prev, curr) => prev + curr)
        }).sort((a, b) => b-a).slice(0, 3).reduce((prev, curr) => prev + curr)

        return max?.toString() ?? "";
    }
}

export default new Day1;