function zeros (n)
{
  // your code here 
  let factorial ;
  if(n==0)
  {
    factorial  =0 
  }
  else
  (
    factorial=1
  )


      for(let i=1;i<=n;i++)
    {
      
        factorial*=i;
    }
  
    console.log(factorial)
    return factorial;
}   
zeros (12)