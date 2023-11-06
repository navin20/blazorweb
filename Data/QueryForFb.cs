using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;
using Firebase.Auth;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace blazorweb.Data
{
 class QueryForFb
    {
        // private FirebaseAuthLink _userCredentialss;

        // FirebaseAuthProvider auth;

        // firebase realtime database, firestore and firebase authentication , firebase storage

        public static void GetData(String table){

        }

        public static void InsertData(string table, Object data){

        }
        
        public static  void DeleteData(string table, Object data, string wherecondition){

        }

        public static void UpdateData(string table, Object data, string wherecondition){

        }

        public static  void JoinTable( String table1, String table2){


        }
        // public static async Task<string?> Login(string email, string password){

            public static async Task<Firebase.Auth.FirebaseAuthLink> SignOut(){
                

                  
              var auth = new FirebaseAuthProvider(
                            new FirebaseConfig("AIzaSyB9x30W5fV10Weyjs0c6VdNqlCzmtBtFrg"));  

                            FirebaseAuthLink credentials = null;

                            return credentials;  

              

            }
            public static async Task<Firebase.Auth.FirebaseAuthLink?> LoginData(string email,string password){
            
              var auth = new FirebaseAuthProvider(
                            new FirebaseConfig("AIzaSyB9x30W5fV10Weyjs0c6VdNqlCzmtBtFrg"));   

                         


                            // try{
                                 

                                //  Console.WriteLine(userCredentials.User);

                            //      if(userCredentials!=null){
                            //  return true;
                            //      }else{
                            //         return false;

                            //      }

                            try{
                                FirebaseAuthLink userCredentials = await auth.SignInWithEmailAndPasswordAsync(email,password);
                            //    auth.SignOut();
                                Console.WriteLine(userCredentials.User.LocalId);
                                return userCredentials;

                                
                            }catch(Exception error){
                                Console.WriteLine(error);
                                return null;

                            }
                                

                                //  return true;

                            // // }catch(Exception error){
                            //     return false;

                            //     // return false;
                               
                            // return false;


            // return false;

        }
           
        
        public static  async Task <bool> RegisterforAuthentication(string email, string password){
          var auth = new FirebaseAuthProvider(
                            new FirebaseConfig("AIzaSyB9x30W5fV10Weyjs0c6VdNqlCzmtBtFrg"));    
                            Console.WriteLine("here");


                            try{
                               
                                await auth.CreateUserWithEmailAndPasswordAsync(email, password);
                               
                                 return true;

                            }catch(Exception error){
                                Console.WriteLine(error);
                                // throw error;

                                return false;
                               
                            }


            // return false;

        }
        public static  async  Task<bool>  RegisterUserData(Registering? data ){
                var Firebase = new FirebaseClient("https://cinema-b752f-default-rtdb.asia-southeast1.firebasedatabase.app/");


            try{

                data!.Password = "";
                data!.ConfirmPassword  = "";



                 
                await Firebase.Child("OrganizerData").PostAsync(data);




                return true;




            }catch(Exception error){

                Console.WriteLine(error);

               return false;

            }

            


        }

        public static void UploadImage(Object data, string storageurl){

        }
        public static void GetImage(Object Data, string storageurl){
            
        }

    }
}