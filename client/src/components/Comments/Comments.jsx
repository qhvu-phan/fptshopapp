import React from "react";
import { Avatar, Grid, Paper } from "@material-ui/core";
import TextField from "@mui/material/TextField";
import { Button } from "@mui/material";

const Comments = () => {
  const imgLink =
    "data:image/jpeg;base64,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";
  const comment = [
    { name: "Huy Vũ", cmt: "Sản phẩm đẹp quá ạ", time: "comment 1 phút trước" },
    { name: "Huy Vũ", cmt: "Sản phẩm như qq", time: "comment 30 phút trước" },
    { name: "Huy Vũ", cmt: "Sản phẩm quá sịn", time: "comment 45 phút trước" },
    {
      name: "Huy Vũ",
      cmt: "Sản phẩm đẹp quá ạ",
      time: "comment 56 phút trước",
    },
  ];
  return (
    <div style={{ padding: 14 }} className="comment">
      <h1>Đánh giá</h1>
      <div>
        <TextField
          style={{ marginBottom: 10 }}
          fullWidth
          id="standard-basic"
          label="Viết đánh giá của bạn"
          variant="standard"
        />
        <div style={{ textAlign: "right" }}>
          <Button
            style={{
              borderRadius: 35,
              backgroundColor: "#21b6ae",
              padding: "9px 18px",
              fontSize: "18px",
              margin: "0 10px",
              marginRight: "0",
            }}
            variant="contained"
          >
            Đánh giá
          </Button>
        </div>
      </div>
      <div className="list_comment">
        {comment.map((item) => {
          return (
            <Paper style={{ padding: "40px 20px", marginTop: 20 }}>
              <Grid container wrap="nowrap" spacing={2}>
                <Grid item>
                  <Avatar alt="Remy Sharp" src={imgLink} />
                </Grid>
                <Grid justifyContent="left" item xs zeroMinWidth>
                  <h4 style={{ margin: 0, textAlign: "left" }}>{item.name}</h4>
                  <p style={{ textAlign: "left" }}>{item.cmt}</p>
                  <p style={{ textAlign: "left", color: "gray" }}>
                    {item.time}
                  </p>
                </Grid>
              </Grid>
            </Paper>
          );
        })}
      </div>
    </div>
  );
};

export default Comments;
