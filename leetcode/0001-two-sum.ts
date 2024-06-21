function twoSum(nums: number[], target: number): number[] {
    let answer: number[];

    for(var i = 0; i < nums.length; i++){
        for(var j = i + 1; j < nums.length; j++){
            if((nums[i] + nums[j]) == target) {
                answer = [i,j]
                return answer;
            }
        }
    }
    
    return answer;
};

function twoSum(nums: number[], target: number): number[] {
    let answer: number[];

    for(var i = 0; i < nums.length; i++){
        let findVal = target - nums[i];
        let numsToSearch = nums.slice(i+1);
        let secondIndex = numsToSearch.findIndex((element) => element == findVal);
        if (secondIndex != -1) {
            answer = [i, secondIndex + i];
            return answer;
        }
    }
    
    return answer;
};