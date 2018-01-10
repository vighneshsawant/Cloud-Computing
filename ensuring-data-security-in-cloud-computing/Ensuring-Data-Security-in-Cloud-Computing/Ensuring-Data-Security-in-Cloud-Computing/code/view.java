import java.io.*;
import java.awt.*;
import java.awt.event.*;
import javax.swing.*;

import java.util.*;


public class view extends JFrame
{
	private TextArea txtArea = null;
		EBCDIC a;	
	public view()
	{
	super("Hackers Information");
	Container pane = this.getContentPane();
	txtArea = new TextArea();
	pane.add(txtArea);
	setSize(500,500);
	setVisible(true);
String s="";
				
try
{
		FileReader fr = new FileReader("attackinfo.txt");
		BufferedReader br = new BufferedReader(fr);		
		String val=new String();
		while((val=br.readLine())!=null)
	        s=s+val+"\n";
}catch(Exception e){}
a=new EBCDIC();

	txtArea.setText(a.encrypt(s));
	}


public static void main(String arg[])
	{
	new view();
	}
}

