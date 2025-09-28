using System;
using System.Web;
using VDT.GuessLib;

public partial class api : System.Web.UI.Page
{
    // Use a server-side static engine per AppDomain (simple). If you want per-session,
    // you can store engine in Session instead: Session["engine"] = engine
    private static GuessEngine engine;

    protected void Page_Load(object sender, EventArgs e)
    {
        // Initialize engine if null
        if (engine == null)
        {
            engine = new GuessEngine();
        }

        // Allow simple cross-origin for local testing (be careful in real deployment)
        Response.AddHeader("Access-Control-Allow-Origin", "*");
        Response.ContentType = "application/json; charset=utf-8";

        string action = Request.Form["action"];
        if (String.IsNullOrEmpty(action))
        {
            action = Request.QueryString["action"];
        }

        if (String.Equals(action, "new", StringComparison.OrdinalIgnoreCase))
        {
            engine.ResetSecret();
            string outstr = "{\"result\":\"Số mới đã tạo. " + EscapeJson(engine.Signature) + "\"}";
            Response.Write(outstr);
            Response.End();
            return;
        }
        else if (String.Equals(action, "guess", StringComparison.OrdinalIgnoreCase))
        {
            string val = Request.Form["value"];
            if (String.IsNullOrEmpty(val))
            {
                val = Request.QueryString["value"];
            }
            int g;
            if (!Int32.TryParse(val, out g))
            {
                Response.Write("{\"result\":\"Giá trị truyền lên không hợp lệ.\"}");
                Response.End();
                return;
            }
            string res = engine.Guess(g);
            Response.Write("{\"result\":\"" + EscapeJson(res) + "\"}");
            Response.End();
            return;
        }
        else
        {
            Response.Write("{\"result\":\"Không có action hợp lệ. Sử dụng action=guess hoặc action=new.\"}");
            Response.End();
            return;
        }
    }

    // Minimal JSON escaper for basic characters
    private string EscapeJson(string s)
    {
        if (s == null) return "";
        return s.Replace("\\", "\\\\").Replace("\"", "\\\"").Replace("\r", " ").Replace("\n", " ");
    }
}
