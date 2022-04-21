import "./App.css";
import { Routes, Route } from "react-router-dom";
import ProductDetails from "./components/ProductDetails/ProductDetails";
import Page from "./components/Page/Page";
import Login from "./components/Login/Login";
import Register from "./components/Register/Register";

function App() {
  return (
    <Routes>
      <Route exact path="/" element={<Page />} />
      <Route path="/login" element={<Login />} />
      <Route path="register" element={<Register />} />
      <Route path="/productdetails" element={<ProductDetails />} />
    </Routes>
  );
}

export default App;
