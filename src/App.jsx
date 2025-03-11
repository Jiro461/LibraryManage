import HomePage from './pages/HomePage/HomePage'
import LoginPage from './pages/LoginPage/LoginPage'
import {BrowserRouter, Routes, Route} from "react-router-dom"
import RegisterPage from './pages/RegisterPage/RegisterPage'
import PrivateRoutes from './routes/PrivateRoutes'

function App() {
  return (
    <BrowserRouter>
      <Routes>
        {/* PublicRoutes */}
        <Route path="/login" element={<LoginPage/>}/>
        <Route path="/register" element={<RegisterPage/>}/>

        {/* PrivateRoutes */}
        <Route element={<PrivateRoutes />}>
          <Route path="/" element={<HomePage/>}/>
        </Route>
      </Routes>
    </BrowserRouter>
  )
}

export default App
