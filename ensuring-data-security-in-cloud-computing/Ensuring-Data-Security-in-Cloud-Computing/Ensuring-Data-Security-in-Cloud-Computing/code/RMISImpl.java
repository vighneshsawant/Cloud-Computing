 import java.io.*;
import java.rmi.*;
import java.rmi.server.*;
import java.rmi.Naming;

public class RMISImpl extends UnicastRemoteObject implements RMISIntf
{
	String user,pass,c;

public RMISImpl() throws RemoteException{ }

public String CliDet(String a, String b, String c) throws Exception{
	this.user=a;
	this.pass=b;
	this.c=c;
	
	System.out.println(a);
	System.out.println(b);
	System.out.println(c);
	dbcon ob=new dbcon();
	String ch=ob.check(user,pass);
	if(ch.equals("ok"))
		{
		 ch=ob.listfile(c);
		}	
	
	return  ch;

}

public String CliDet_key(String user,String key)throws Exception
{

	
	System.out.println(user);
	System.out.println(key);
	dbcon ob=new dbcon();
	String ch=ob.check_key(user,key);
	return  ch;

}
public String checkipp(String ip,String option) throws Exception
{
dbcon ob=new dbcon();
String ch=ob.checkip(ip);
String op=ob.checkfileoption(option);
return ch+";"+op; 
}

public void store(String aa[],String ip,String username,String fn ) throws Exception
{
System.out.println(aa[0]+aa[1]+aa[2]+ip);

String s="[USER:"+username+"\nFILE:"+fn+"\nFROM IP:"+ip+"\nENTERING PASSWORD:"+aa[0]+","+aa[1]+","+aa[2]+"\nDATE:"+aa[3]+"]\n";
emserver.msg="user="+username+":IP="+ip;
EBCDIC a=new EBCDIC();
		byte b[]=(a.decrypt(s)).getBytes();
		OutputStream o=new FileOutputStream("attackinfo.txt",true);
		o.write(b);
		o.close();	
//emserver.msg=null;
}
/*public File res(String filename,  String ip) throws Exception
{
File fil;
	dbcon ob=new dbcon();
	String ch=ob.checkip(ip);
	if(ch.equals("ok"))
		{
		 ch=ob.getfake(filename);
		 fil=new File(ch);	
		}	
	else
		{	
		 fil=new File(filename);	
		}
	System.out.println("server:file"+fil);	

	return fil;
}*/
//////change
public String  res(String filename,  String ip,String fileop) throws Exception
{
File fil;
	dbcon ob=new dbcon();
	String ch=ob.checkip(ip);
	if(ch.equals("ok")||fileop.equals("true"))
		{
		 ch=ob.getfake(filename);
		 fil=new File(ch);	
		}	
	else
		{	
		 fil=new File(filename);	
		}
	System.out.println("server:file"+fil);	

String s="";
				 File f= fil;
				 //new File(filename);
			         FileReader fr = new FileReader(f);
			         BufferedReader br = new BufferedReader(fr);		
			         String val=new String();
			         while((val=br.readLine())!=null)
			         s=s+val+"\n";
				 //System.out.println(s);				
return s;
}
////////////
/*
public static void main(String a[]){
		try	{
	                              	RMISImpl rmisimpl = new RMISImpl();
               	         		Naming.rebind("RMIServer",rmisimpl);
			System.out.println("Server Is Runnig...");
	                             }
		catch(Exception e)
                                   {
			System.out.println("Exception :" +e);
		}

}
*/
}


