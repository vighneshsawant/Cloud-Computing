import java.awt.*;
import java.awt.event.*;
import java.io.PrintStream;
import java.rmi.Naming;
import java.util.StringTokenizer;
import java.util.Vector;
import javax.swing.*;
import javax.swing.border.*;

public class Server extends JFrame
{

    private JPanel contentpane;
    private JPanel RemoveIP;
    private JPanel jPanel2;
	private JButton AddIP;
    private JButton AddRes;
    private JButton RemoveRes;
    private JButton StartSer;
    private JButton Startview;
    private JButton Startmobilealert;
    private JButton Adduser;
    private JButton removeIP;
    private JButton addIP;
    private JButton addRes;
    private JLabel jLabel1;
    private JLabel jLabel2;
    private JLabel headlabl;
	private JLabel headlab2;
    private JList jList1;
    private JList jList2;

    private JOptionPane op;
    private static JFrame frame = null;

    public Server()
    {
   op=new JOptionPane();
        contentpane = (JPanel) this.getContentPane();   
        StartSer = new JButton();
        Startview = new JButton();
       Startmobilealert=new JButton();
        Adduser=new JButton();
        RemoveIP = new JPanel();
        jLabel1 = new JLabel();
        jList1 = new JList();
        AddIP = new JButton();
        removeIP = new JButton();
///
        addIP = new JButton();
        jPanel2 = new JPanel();
        jLabel2 = new JLabel();
        headlabl=new JLabel();
		 headlab2=new JLabel();
         jList2 = new JList();
        AddRes = new JButton();
        RemoveRes = new JButton();
        addRes = new JButton();
///////////
        contentpane.setLayout(null);
        this.setSize(new Dimension(900, 620));
//        this.setResizable(false);
        this.setTitle("Ensuring Data Storage Security in Cloud Computing");
	headlabl.setText("Ensuring Data Storage Security in Cloud Computing");
	headlab2.setText("Cloud Authentication Server ");
	
	headlabl.setForeground(new Color(255, 0, 10 ));
    	//headlabl.setBackground(new Color(255, 255, 255));
		headlabl.setFont(new Font("Arial", 0, 20));
	headlabl.setBounds(200, 0, 800, 30);
	contentpane.add(headlabl,null);
        //setBackground(new Color(254, 253, 184));

		headlab2.setForeground(new Color(255, 100, 0));
    	//headlabl.setBackground(new Color(255, 255, 255));
		headlab2.setFont(new Font("Arial", 0, 20));
	headlab2.setBounds(300, 15, 500, 70);
	contentpane.add(headlab2,null);
		
        addWindowListener(new WindowAdapter() {

            public void windowClosing(WindowEvent windowevent)
            {
                exitForm(windowevent);
            }

        });

        StartSer.setBackground(new Color(36, 72, 72));
        StartSer.setFont(new Font("Arial", 0, 14));
        StartSer.setForeground(new Color(255, 255, 255));
        StartSer.setText("Start Server");
        StartSer.setBorder(new BevelBorder(0));
        StartSer.addActionListener(new ActionListener() {

            public void actionPerformed(ActionEvent actionevent)
            {
                StartSerActionPerformed(actionevent);
            }

        });
        contentpane.add(StartSer,null);
        StartSer.setBounds(30, 65, 140, 23);
///
        Startview.setBackground(new Color(36, 72, 72));
        Startview.setFont(new Font("Arial", 0, 14));
        Startview.setForeground(new Color(255, 255, 255));
        Startview.setText("Hackers Info");
        Startview.setBorder(new BevelBorder(0));
        Startview.addActionListener(new ActionListener() {

            public void actionPerformed(ActionEvent actionevent)
            {
                StartviewActionPerformed(actionevent);
            }

        });
        contentpane.add(Startview,null);
        Startview.setBounds(210, 65, 140, 23);

//////////
        Startmobilealert.setBackground(new Color(36, 72, 72));
        Startmobilealert.setFont(new Font("Arial", 0, 14));
        Startmobilealert.setForeground(new Color(255, 255, 255));
        Startmobilealert.setText("Enable Mobile Alert");
        Startmobilealert.setBorder(new BevelBorder(0));
        Startmobilealert.addActionListener(new ActionListener() {

            public void actionPerformed(ActionEvent actionevent)
            {
                StartmobilealertActionPerformed(actionevent);
            }

        });
        contentpane.add(Startmobilealert,null);
        Startmobilealert.setBounds(380, 65, 140, 23);

///
//////////
        Adduser.setBackground(new Color(36, 72, 72));
        Adduser.setFont(new Font("Arial", 0, 14));
        Adduser.setForeground(new Color(255, 255, 255));
        Adduser.setText("Add Newuser");
        Adduser.setBorder(new BevelBorder(0));
        Adduser.addActionListener(new ActionListener() {

            public void actionPerformed(ActionEvent actionevent)
            {
                AdduserActionPerformed(actionevent);
            }

        });
        contentpane.add(Adduser,null);
        Adduser.setBounds(560, 65, 140, 23);

///
        RemoveIP.setLayout(null);
        RemoveIP.setBackground(new Color(0, 116, 232));
        RemoveIP.setBorder(new EtchedBorder());
        jLabel1.setFont(new Font("Arial", 0, 17));
		jLabel1.setForeground(new Color(255, 255, 255));
        jLabel1.setText("Restricted IP Addresses:");
        RemoveIP.add(jLabel1);
        jLabel1.setBounds(20, 10, 200, 40);
        jList1.setBorder(new BevelBorder(2));
        RemoveIP.add(jList1);
        jList1.setBounds(10, 70, 220, 450);
        AddIP.setBackground(new Color(205, 205, 205));
        AddIP.setFont(new Font("Arial", 0, 14));
        AddIP.setForeground(new Color(0, 0, 0));
        AddIP.setText("View");
        AddIP.setBorder(new SoftBevelBorder(0));
        AddIP.addActionListener(new ActionListener() {

            public void actionPerformed(ActionEvent actionevent)
            {
                AddIPActionPerformed(actionevent);
            }

        });
        RemoveIP.add(AddIP);
        AddIP.setBounds(250, 70, 110, 25);
//new ip
        removeIP.setBackground(new Color(205, 205, 205));
        removeIP.setFont(new Font("Arial", 0, 15));
        removeIP.setForeground(new Color(0, 0, 0));
        removeIP.setText("Remove IP");
        removeIP.setBorder(new SoftBevelBorder(0));
        removeIP.addActionListener(new ActionListener() {

            public void actionPerformed(ActionEvent actionevent)
            {
                removeIPActionPerformed(actionevent);
            }

        });
        RemoveIP.add(removeIP);
        removeIP.setBounds(250, 110, 110, 25);

////////////new addip
        addIP.setBackground(new Color(205, 205, 205));
        addIP.setFont(new Font("Arial", 0, 15));
        addIP.setForeground(new Color(0, 0, 0));
        addIP.setText("Add New IP");
        addIP.setBorder(new SoftBevelBorder(0));
        addIP.addActionListener(new ActionListener() {

            public void actionPerformed(ActionEvent actionevent)
            {
                addIPActionPerformed(actionevent);
            }

        });
        RemoveIP.add(addIP);
        addIP.setBounds(250, 150, 110, 25);

////////////
        contentpane.add(RemoveIP,null);
        RemoveIP.setBounds(30, 90, 400, 550);
        jPanel2.setLayout(null);
        jPanel2.setBackground(new Color(0, 116, 232));
        jPanel2.setBorder(new EtchedBorder());
        jLabel2.setFont(new Font("Arial", 0, 17));
		jLabel2.setForeground(new Color(255, 255, 255));
        jLabel2.setText("Available Resources:");
        jPanel2.add(jLabel2);
        jLabel2.setBounds(10, 10, 200, 40);
        jList2.setBorder(new BevelBorder(2));
        jPanel2.add(jList2);
        jList2.setBounds(10, 70, 220, 450);
        AddRes.setBackground(new Color(205, 205, 205));
        AddRes.setFont(new Font("Arial", 0, 15));
        AddRes.setForeground(new Color(0, 0, 0));
        AddRes.setText("View");
        AddRes.setBorder(new SoftBevelBorder(0));
        AddRes.addActionListener(new ActionListener() {

            public void actionPerformed(ActionEvent actionevent)
            {
                AddResActionPerformed(actionevent);
            }

        });
        jPanel2.add(AddRes);
        AddRes.setBounds(250, 70, 110, 25);
        RemoveRes.setBackground(new Color(205, 205, 205));
        RemoveRes.setFont(new Font("Arial", 0, 15));
        RemoveRes.setForeground(new Color(0, 0, 0));
        RemoveRes.setText("Remove ");
        RemoveRes.setBorder(new SoftBevelBorder(0));
        RemoveRes.addActionListener(new ActionListener() {

            public void actionPerformed(ActionEvent actionevent)
            {
                RemoveResActionPerformed(actionevent);
            }

        });
        jPanel2.add(RemoveRes);
        RemoveRes.setBounds(250, 110, 110, 25);
/////////////new Res
	addRes.setBackground(new Color(205, 205, 205));
        addRes.setFont(new Font("Arial", 0, 15));
        addRes.setForeground(new Color(0, 0, 0));
        addRes.setText("Add New File");
        addRes.setBorder(new SoftBevelBorder(0));
        addRes.addActionListener(new ActionListener() {

            public void actionPerformed(ActionEvent actionevent)
            {
                addResActionPerformed(actionevent);
            }

        });
        jPanel2.add(addRes);
        addRes.setBounds(250, 150, 110, 25);
/////////////////
        contentpane.add(jPanel2,null);
        jPanel2.setBounds(470, 90, 400, 550);
        pack();
    }

    private void StartSerActionPerformed(ActionEvent actionevent)
    {
        try
        {
            RMISImpl rmisimpl = new RMISImpl();
            Naming.rebind("RMIServer", rmisimpl);
            System.out.println("Server Is Runnig...");
        }
        catch(Exception exception)
        {
            System.out.println("Exception :" + exception);
        }
    }

//
    private void StartmobilealertActionPerformed(ActionEvent actionevent)
    {
        try
        {
emserver ob=new emserver();
ob.start();
       System.out.println("Mobile Alert Service Running....... ");
        }
        catch(Exception exception)
        {
            System.out.println("Exception :" + exception);
        }
    }
//
//
private void AdduserActionPerformed(ActionEvent actionevent)
    {
        try
        {
     
	new NewUser().show();
	 }
        catch(Exception exception)
        {
            System.out.println("Exception :" + exception);
        }
    }

//

//
private void StartviewActionPerformed(ActionEvent actionevent)
    {
      new view();
    }
//
    private void RemoveResActionPerformed(ActionEvent actionevent)
    {	dbcon dbcon1 = new dbcon();
	String sss=(String) jList2.getSelectedValue();
	System.out.println("selected:"+sss);
	dbcon1.removede(sss,"RESOURCES","files");
	rss();
    }
    private void addResActionPerformed(ActionEvent actionevent)
    {
	String Fn=(String)JOptionPane.showInputDialog(this,"Enter The new FileName:");
	String fFn=(String)JOptionPane.showInputDialog(this,"Enter The fake FileName:");
	String op1=(String)JOptionPane.showInputDialog(this,"Enter The option of FileSecurity:","false");
	String ip=(String)JOptionPane.showInputDialog(this,"Enter The IP Address:");

if(Fn==null || fFn==null || op1==null ||Fn.equals("")||fFn.equals("")||op1.equals(""))
	{
	op.showConfirmDialog(this,"Enter proper Data Only","Alert",JOptionPane.DEFAULT_OPTION,JOptionPane.ERROR_MESSAGE);
	}
else
	{
	add_rss(Fn,fFn,op1,ip);
	}

    }

private void addIPActionPerformed(ActionEvent actionevent)
    {
String a=(String)JOptionPane.showInputDialog(this,"Enter The new IPAddress:");
new_addipr(a);
System.out.println("addip called"+a);
    }
private void rss()
{
dbcon dbcon1 = new dbcon();
        String s = dbcon1.listfile();
        Vector vector = new Vector(2);
        String s1;
        for(StringTokenizer stringtokenizer = new StringTokenizer(s, ";"); stringtokenizer.hasMoreTokens(); vector.addElement(s1))
        {
            s1 = stringtokenizer.nextToken();
        }

        jList2.setListData(vector);

}
private void add_rss(String f,String ff,String op,String allowedip)
{
        dbcon dbcon1 = new dbcon();
       dbcon1.add_res(f,ff,op,allowedip);
        String s = dbcon1.listfile();
        Vector vector = new Vector(2);
        String s1;
        for(StringTokenizer stringtokenizer = new StringTokenizer(s, ";"); stringtokenizer.hasMoreTokens(); vector.addElement(s1))
        {
            s1 = stringtokenizer.nextToken();
        }

        jList2.setListData(vector);

}


    private void AddResActionPerformed(ActionEvent actionevent)
    {

rss();
     }
private void ipr()
{
	dbcon dbcon1 = new dbcon();
       	 String s = dbcon1.listip();
      	  Vector vector = new Vector(2);
      	  String s1;
      	  for(StringTokenizer stringtokenizer = new StringTokenizer(s, ";"); stringtokenizer.hasMoreTokens(); vector.addElement(s1))
      		  {
           		 s1 = stringtokenizer.nextToken();
        		  }

        jList1.setListData(vector);


}

private void new_addipr(String ip_n)
{
	dbcon dbcon1 = new dbcon();
	dbcon1.add_ip(ip_n);
	String s = dbcon1.listip();
      	Vector vector = new Vector(2);
      	String s1;
      	for(StringTokenizer stringtokenizer = new StringTokenizer(s, ";"); stringtokenizer.hasMoreTokens(); vector.addElement(s1))
      		  {
           		 s1 = stringtokenizer.nextToken();
        		  }

        jList1.setListData(vector);


}



    private void removeIPActionPerformed(ActionEvent actionevent)
    {	
	String a=(String)JOptionPane.showInputDialog(this,"Enter The Key Word");
	if(a.equals("admin"))
	{	
	dbcon dbcon1 = new dbcon();
	String sss=(String) jList1.getSelectedValue();
	System.out.println("selected:"+sss);
	dbcon1.removede(sss,"ADDRESS","IPADDRESS");
	ipr();
	}
	else
	{
	op.showConfirmDialog(this,"Check The Key or Select Ip","Alert",JOptionPane.DEFAULT_OPTION,JOptionPane.ERROR_MESSAGE);
	}

    }

    private void AddIPActionPerformed(ActionEvent actionevent)
    {
	ipr();
    }


    private void exitForm(WindowEvent windowevent)
    {
        System.exit(0);
    }
static void showMiddle(){
    Dimension screenSize = Toolkit.getDefaultToolkit().getScreenSize();
    Dimension frameSize = frame.getSize();
    if (frameSize.height > screenSize.height) {
      frameSize.height = screenSize.height;
    }
    if (frameSize.width > screenSize.width) {
      frameSize.width = screenSize.width;
    }
    frame.setLocation((screenSize.width - frameSize.width) / 2, (screenSize.height - frameSize.height) / 2);
    frame.setVisible(true);
 
}

    public static void main(String args[])
    {
	Server frame = new Server();
	ImageIcon image1 = new ImageIcon(LoginDialog.class.getResource("images/network.JPG"));
	LoginDialog dia = new LoginDialog();
	JSplashScreen sp = new JSplashScreen(image1);
	sp.displayForm();
	dia.setSize(780,580);
	dia.showDialog();
	if(dia.getConfirm()){
		sp.closeSplashScreen();
		//frame.setVisible(true);
		frame.setSize(900,700);
		////
		frame.show();//Middle();
		
    	}
	else {
		sp.closeSplashScreen();
		System.exit(1);
	}
      
    }
}
