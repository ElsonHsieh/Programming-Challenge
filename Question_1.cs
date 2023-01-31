class Solution {
    public int solution(int[] A) {
        int _result = 0;
        if (A.Length == 0) return _result;
        int _max = ArrayMax(A);	//find the max number in array A
        bool[] _count = new bool[_max+2]; //array for recording all occurred numbers

         //record all the found numbers in array _count.
         for(int k=0; k < A.Length; k++){
             if (A[k] > 0 && !_count[ A[k] ]) _count[ A[k] ] = true;  
         }

         //find the positive number that hasn't occurred.
         for(int k=1; k < _count.Length; k++) {
             if (!_count[k]) return k;
         }

        return _result;
    }

    public int ArrayMax(int[] A) {
        int _max = 0;
        
        for(int i=0; i<A.Length;i++){
            if (_max < A[i]) _max = A[i]; 
        }

        return _max;
    }

}
