class Solution {
    public int solution(int[] A) {
        int _countOfEast = 0;
        int _result = 0;

        for(int i=0; i < A.Length; i++){
            if (A[i] == 0) _countOfEast++; //the count of eastbound
            if (A[i] == 1) _result += _countOfEast; //the count of eastbound cars that this westbound car will meet
            if (_result > 1000000000) return -1;
        }

        return _result;
    }
}
