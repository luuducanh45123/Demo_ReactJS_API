'use client'

import { useRouter } from 'next/navigation'
import '@/styles/login.css'
import React, { useState } from 'react'


export default function Login() {
    const [ username, setUserName ] = useState('')
    const [ password, setPassword ] = useState('')
    const router = useRouter()

    function handlerSubmit(e: React.FormEvent) {
        e.preventDefault()

        // console.log('login with', { username, password })

        if (username && password) {
            localStorage.setItem('isLoggedIn', 'true')
            router.push('/') 
        }
    }

    return (
        <div className="container">
            <form className="form" onSubmit={handlerSubmit}>
                <h2 className="tile text-center">Đăng Nhập</h2>
                <input type="text"
                    className="input"
                    value={username}
                    onChange={(e) => setUserName(e.target.value)}
                />
                <input type="password"
                    className="input"
                    value={password}
                    onChange={(e) => setPassword(e.target.value)}
                />

                <button type="submit" className="button">Đăng nhập</button>
            </form>
        </div>
    )
}

