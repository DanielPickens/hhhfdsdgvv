private void bw_DoWork(object sender, DoWorkEventArgs e)
{
	try
	{
        byte[] buf;
        if (random == true)
        {
            buf = System.Text.Encoding.ASCII.GetBytes(String.Format("GET {0}{1} HTTP/1.1{2}Host: {3}{2}{2}{2}", Subsite, new Functions().RandomString(), Environment.NewLine, Host));
        }
        else
        {
            buf = System.Text.Encoding.ASCII.GetBytes(String.Format("GET {0} HTTP/1.1{1}Host: {2}{1}{1}{1}", Subsite, Environment.NewLine, Host));
        }
