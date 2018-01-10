import java.io.*;
import java.rmi.*;

public interface RMISIntf extends Remote{

public String CliDet(String a, String b,  String c) throws Exception;
public String CliDet_key(String user,String key) throws Exception;
///public File res(String filename,  String ip) throws Exception;
public String res(String filename,  String ip,String fileop) throws Exception;
public String checkipp(String ip,String option) throws Exception;
public void store(String aa[],String ip,String username,String fn) throws Exception;
//public DataTrans();
//public GoLookup();
}
	