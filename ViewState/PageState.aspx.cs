using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PageState {
    public partial class PageState : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            // Prints the objects type.
            Response.Write(ViewState);
            Response.Write("<br>");

            // Prints the count of objects inside view state.
            Response.Write("Objects inside view state are: " + ViewState.Count);
            Response.Write("<br>");

            // Add item to view state.
            // Key is "key".
            // Value is "value".
            ViewState["key"] = "value";
            Response.Write("Objects inside view state are: " + ViewState.Count);
            Response.Write("<br>");

            // Retrieve value from view state.
            Response.Write(ViewState["key"]);
            Response.Write("<br>");

            // View State Documentation.

        }
    }
}