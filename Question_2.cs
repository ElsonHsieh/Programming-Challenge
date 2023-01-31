class Solution {
    public int solution(int X, int[] A) {
         int _result = -1;
        if (A.Length==0) return _result;
        bool[] _arr = new bool[X+1];
        int _x = 0;  //the count of appeared leaves
        
        //j stands for Second
        for(int j=0;j<A.Length;j++){

        	//mark true to the leaf when it first appears and increment leaf count 
            if (!_arr[ A[j] ]) {
                _arr[ A[j] ] = true;
                _x++;
            }

            //return Second if the count of appeared leaves is equal to the total position
            if (_x == X){
                return j;
            }
        }

        return _result;

}
