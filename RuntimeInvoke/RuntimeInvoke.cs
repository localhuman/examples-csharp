using System;
using Neo.SmartContract.Framework.Services.Neo;
using Neo.SmartContract.Framework;
         
namespace Neo.SmartContract
{
    public class RuntimeInvoke : Framework.SmartContract
    {
        public static int Main(byte[] script_hash) // script_hash should be byte array of the Smart Contract that adds
        {
            Runtime.Log("hello runime invoke");

            Func<byte[], int, int, int> DynamicAppCall = InvokeAddContract;

            int result = DynamicAppCall(script_hash, 1, 2);

            return result;
        }


        [DynamicCall]
        public static extern int InvokeAddContract(byte[] script_hash, int a, int b);
    }
}
