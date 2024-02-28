function find_max(nums) {
    let max_num = Number.NEGATIVE_INFINITY;

    for (const num of nums) {
        if (num > max_num) {
            max_num += num;
        }
    }
    return max_num
}