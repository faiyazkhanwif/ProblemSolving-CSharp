public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int p1 = m-1;
        int p2 = n-1;

        int insertP = m+n-1;

        while(insertP >= 0){
            if(p2<0){
                nums1[insertP] = nums1[p1];
                p1--;
            }else if(p1<0){
                nums1[insertP] = nums2[p2];
                p2--;
            }else if(nums1[p1]>=nums2[p2]){
                nums1[insertP] = nums1[p1];
                p1--;
            }else {
                nums1[insertP] = nums2[p2];
                p2--;
            }
            
            //Console.WriteLine("--"+nums1[insertP]);
            insertP--;

        }

    }
}