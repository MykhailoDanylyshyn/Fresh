export default function HomePage() {
    return (
        <>
            <header>
                <div>
                    <a href="/" className="logo">FRESH</a>

                    <nav>
                        <a href="#men">Чоловіки</a>
                        <a href="#women">Жінки</a>
                        <a href="#kids">Діти</a>
                        <a href="#clothing">Одяг</a>
                        <a href="#shoes">Взуття</a>
                    </nav>

                    <div>
                        <a href="#login">Увійти</a>
                        <a href="#cart">Кошик</a>
                    </div>
                </div>
            </header>

            <main>
                <section className="hero">
                    <div>
                        <h1>Твій стиль. Твої правила.</h1>
                        <p>
                            Відкрий для себе нову колекцію одягу та взуття.
                        </p>
                        <a href="#new-arrivals">Переглянути колекцію</a>
                    </div>
                </section>

                <section id="new-arrivals">
                    <h2>Новинки</h2>

                    <div className="products">
                        <p>Тут будуть нові товари з каталогу.</p>
                    </div>
                </section>

                <section id="popular">
                    <h2>Популярні товари</h2>

                    <div className="products">
                        <p>Тут будуть популярні товари з каталогу.</p>
                    </div>
                </section>
            </main>

            <footer>
                <p>© 2026 Fresh. Усі права захищені.</p>
            </footer>
        </>
    );
}

