using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncaoParams {
    internal class Calculadora {
        public static int Sum(params int[] nums) {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++) {
                sum += nums[i];
            }
            return sum;
        }
    }
}
